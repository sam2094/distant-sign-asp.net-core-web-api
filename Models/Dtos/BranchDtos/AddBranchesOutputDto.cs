using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dtos.BranchDtos
{
    public class AddBranchesOutputDto
    {
        public int BranchPosition { get; set; }
        public string BranchName { get; set; }
        public string Message { get; set; }
        public bool IdAdded { get; set; }
    }
}
