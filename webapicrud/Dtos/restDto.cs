using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapicrud.Dtos
{
    public class restDto
    {

        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email{ get; set; }




    }
}