using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog3.Models
{
    public class EditModel
    {
        public int Id { get; set; }

        [Required]
        public string Cim { get; set; }

        [Required]
        public string Tartalom { get; set; }
        public DateTime Idopont { get; set; }

        public EditModel()
        {

        }

        public EditModel(int id, string cim, string tartalom, DateTime idopont)
        {
            this.Id = id;
            this.Cim = cim;
            this.Tartalom = tartalom;
            this.Idopont = idopont;
        }
    }
}