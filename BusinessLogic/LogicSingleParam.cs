using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using log4net;
using Models.LogicParameters;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class LogicSingleParam<TOutput>
    where TOutput : LogicOutput, new()
    {
        protected static readonly ILog _logger;

        /// <summary>
        /// Output of the logic
        /// </summary>
        public LogicResult<TOutput> Result;

        protected readonly IUnitOfWork _uow;
        private readonly string _firstExecutedLogicName;
        private readonly bool _beginTransaction;

        static LogicSingleParam()
        {
            _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public LogicSingleParam(IUnitOfWork uow, string firstExecutedLogicName, bool beginTransaction = false)
        {
            _uow = uow;
            _firstExecutedLogicName = firstExecutedLogicName;
            _beginTransaction = beginTransaction;
            Result = new LogicResult<TOutput>
            {
                Output = new TOutput()
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters">Input of the logic. If the method doesn't need input, you have to send empty input object</param>
        /// <returns></returns>
        public LogicResult<TOutput> Execute()
        {
            try
            {
                _logger.Info($"Executing process started from this class : {GetType()}");

                Begin(_beginTransaction);

                DoExecute();

                if (!Result.IsSuccess)
                {
                    RollBack(_beginTransaction);
                    _logger.Error($"Error occured from this class : {GetType()} : {Result.ErrorList.FirstOrDefault().ErrorMessage}");
                    return Result;
                }

                Commit(_beginTransaction);

                _logger.Info($"Executing process finished from this class : {GetType()}");
            }
            catch (Exception ex)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.INTERNAL_ERROR,
                    ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                    StatusCode = ErrorHttpStatus.INTERNAL
                });

                _logger.Error($"Error occured from this class : {GetType()} : {ex.ToString()}");
            }

            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters">Input of the logic. If the method doesn't need input, you have to send empty input object</param>
        /// <param name="beginTransaction">If you want to use entity framework transaction, you must set this parameter true. IMPORTANT: You should set this parameter only when you call from services.</param>
        /// <returns></returns>
        public async Task<LogicResult<TOutput>> ExecuteAsync()
        {
            try
            {
                _logger.Info($"Executing process started from this class : {GetType()}");

                await BeginAsync(_beginTransaction);

                await DoExecuteAsync();

                if (!Result.IsSuccess)
                {
                    await RollBackAsync(_beginTransaction);
                    _logger.Error($"Error occured from this class : {GetType()} : {Result.ErrorList.FirstOrDefault().ErrorMessage}");
                    return Result;
                }

                await CommitAsync(_beginTransaction);

                _logger.Info($"Executing process finished from this class : {GetType()}");
            }
            catch (Exception ex)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.INTERNAL_ERROR,
                    ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                    StatusCode = ErrorHttpStatus.INTERNAL
                });

                await RollBackAsync(_beginTransaction);

                _logger.Error($"Error occured from this class : {GetType()} : {ex.ToString()}");
            }

            return Result;
        }

        /// <summary>
        /// Main logic method
        /// </summary>
        public virtual void DoExecute() { }

        /// <summary>
        /// Main logic method async
        /// </summary>
        public virtual async Task DoExecuteAsync() { await Task.CompletedTask; }


        /// <summary>
        /// If the instance belong first called logic in logic-chain it will begin transaction
        /// </summary>
        /// <param name="beginTransaction"></param>
        private void Begin(bool beginTransaction)
        {
            if (GetType().Name == _firstExecutedLogicName && beginTransaction)
                _uow.Begin();
        }

        /// <summary>
        /// If the instance belong first called logic in logic-chain it will begin transaction
        /// </summary>
        /// <param name="beginTransaction"></param>
        private async Task BeginAsync(bool beginTransaction)
        {
            if (GetType().Name == _firstExecutedLogicName && beginTransaction)
                await _uow.BeginAsync();
        }

        /// <summary>
        /// If the instance belong first called logic in logic-chain it will commit transaction
        /// </summary>
        /// <param name="beginTransaction"></param>
        private void Commit(bool beginTransaction)
        {
            bool disposed = GetType().Name == _firstExecutedLogicName;
            if (disposed)
            {
                try
                {
                    if (beginTransaction) _uow.Commit();
                }
                catch (Exception ex)
                {
                    Result.ErrorList.Add(new Error
                    {
                        ErrorCode = ErrorCodes.INTERNAL_ERROR,
                        ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                        StatusCode = ErrorHttpStatus.INTERNAL
                    });

                    _logger.Error($"Error occured commit : {ex.ToString()}");
                }
                finally
                {
                    _uow.Dispose();
                }
            }
        }

        /// <summary>
        /// If the instance belong first called logic in logic-chain it will commit transaction
        /// </summary>
        /// <param name="beginTransaction"></param>
        private async Task CommitAsync(bool beginTransaction)
        {
            bool disposed = GetType().Name == _firstExecutedLogicName;
            if (disposed)
            {
                try
                {
                    if (beginTransaction) await _uow.CommitAsync();
                }
                catch (Exception ex)
                {
                    Result.ErrorList.Add(new Error
                    {
                        ErrorCode = ErrorCodes.INTERNAL_ERROR,
                        ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                        StatusCode = ErrorHttpStatus.INTERNAL
                    });

                    _logger.Error($"Error occured commit : {ex.ToString()}");
                }
                finally
                {
                    _uow.Dispose();
                }
            }
        }

        /// <summary>
        /// If the instance belong first called logic in logic-chain it will rollback transaction
        /// </summary>
        /// <param name="beginTransaction"></param>
        private void RollBack(bool beginTransaction)
        {
            bool disposed = GetType().Name == _firstExecutedLogicName;
            if (disposed)
            {
                try
                {
                    if (beginTransaction) _uow.Rollback();
                }
                catch (Exception ex)
                {
                    Result.ErrorList.Add(new Error
                    {
                        ErrorCode = ErrorCodes.INTERNAL_ERROR,
                        ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                        StatusCode = ErrorHttpStatus.INTERNAL
                    });

                    _logger.Error($"Error occured rollback : {ex.ToString()}");
                }
                finally
                {
                    _uow.Dispose();
                }
            }
        }

        /// <summary>
        /// If the instance belong first called logic in logic-chain it will rollback transaction
        /// </summary>
        /// <param name="beginTransaction"></param>
        private async Task RollBackAsync(bool beginTransaction)
        {
            bool disposed = GetType().Name == _firstExecutedLogicName;
            if (disposed)
            {
                try
                {
                    if (beginTransaction) await _uow.RollbackAsync();
                }
                catch (Exception ex)
                {
                    Result.ErrorList.Add(new Error
                    {
                        ErrorCode = ErrorCodes.INTERNAL_ERROR,
                        ErrorMessage = Resource.UNHANDLED_EXCEPTION,
                        StatusCode = ErrorHttpStatus.INTERNAL
                    });

                    _logger.Error($"Error occured rollback : {ex.ToString()}");
                }
                finally
                {
                    _uow.Dispose();
                }
            }
        }
    }
}
