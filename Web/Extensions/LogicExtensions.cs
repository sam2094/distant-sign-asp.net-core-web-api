using Microsoft.AspNetCore.Http;
using Models.LogicParameters;
using System;
using System.Linq;
using System.Security.Claims;

namespace Web.Extensions
{
    public static class LogicExtensions
    {
        public static TInput Authorized<TInput>(this TInput input, HttpContext context) where TInput : LogicInput, new()
        {
            TInput parameter = input ?? new TInput();
            try
            {
                parameter.CurrentUserId = Convert.ToInt32(context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value);
            }
            catch { }
            return parameter;
        }
    }
}
