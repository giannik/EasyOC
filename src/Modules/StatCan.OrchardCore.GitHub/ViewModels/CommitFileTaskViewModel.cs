﻿using System.ComponentModel.DataAnnotations;

namespace StatCan.OrchardCore.GitHub.ViewModels
{
    public class CommitFileTaskViewModel
    {
        [Required]
        public string TokenName { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public string Repo { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string FileContents { get; set; }
        [Required]
        public string CommitMessage { get; set; }
    }
}



