﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Core.Request
{
    public class EditNews
    {
        public int Id { get; set; }
        public int NewsClassifyId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Contents { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Remark { get; set; }
    }
}
