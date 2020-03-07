using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asignment.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int Punishment { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PunishmentDate { get; set; }
        public EnumPunishmentType PunishmentType { get; set; }
        public enum EnumPunishmentType
        {
            Pushup = 1,
            Pay = 2
        }
    }
}