﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INFI.API.Models.RecordDto
{
    public class RecordInfoDto
    {
        public int RId { get; set; }
        public string RecordType { get; set; }
        public string RecordTitle { get; set; }
        public string ApprovalStatus { get; set; }
        public string RecordDatetime { get; set; }
        public string RecordUserName { get; set; }
        public string ApprovalUserName { get; set; }
        public string RecordReason { get; set; }
        public string RecordUserId { get; set; }
        public string ApprovalRemark { get; set; }
        public List<AttachmentMngDto.AttachmentMngDto> AttachmentList { get; set; }
        public List<AttachmentMngDto.AttachmentMngDto> ApproalAttachList { get; set; }
    }
}
