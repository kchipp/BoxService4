using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoxService4.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }

        [Display(Name = "Did you like the wines you received this month?")]
        public bool QuestionOne { get; set; }

        [Display(Name = "Would you order those wines again?")]
        public bool QuestionTwo { get; set; }
    }

}