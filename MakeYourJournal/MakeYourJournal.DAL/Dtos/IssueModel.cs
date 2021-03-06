﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MakeYourJournal.DAL.Dtos
{
    public class IssueModel
    {
        public int Id { get; set; }
        [Required]
        public int Volume { get; set; }
        [Required]
        public int Number { get; set; }
        [Display(Name = "All time issue number")]
        public int AllTime { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Display(Name = "Expected number of pages")]
        public int ExpectedPageCount { get; set; }
        [Display(Name = "Number of copies")]
        public int CopyNumber { get; set; }

        public int ArticleCount { get; set; }
    }
}
