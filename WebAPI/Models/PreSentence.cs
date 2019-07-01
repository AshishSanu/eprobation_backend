using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PreSentence
    {
        [Key]
        public int PSid { get; set; }
        public string CaseNumber { get; set; }
        public string CourtName { get; set; }
        public string NameOfOffender { get; set; }
        public string OffenderFatherName { get; set; }
        public string Address { get; set; }
        public string ActSec { get; set; }
        public string DateOfReceiving { get; set; }
        public string LetterNumber { get; set; }
        public string PoliceStation { get; set; }
        public string PsReportImageName { get; set; }
    }
}
