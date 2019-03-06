using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Моля, въведете собствено име!"),
            Display(Name = "Собствено име: ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Моля, въведете фамилно име!"),
            Display(Name = "Фамилно име:")]
        public string FamilyName { get; set; }
        [Required(ErrorMessage = "Моля, въведете адрес за електронна поща!"),
            Display(Name = "Електронна поща:"),
            RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", 
            ErrorMessage = "Моля, въведете валиден адрес за електронна поща!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Моля, изберете вида на запитването!"),
            Display(Name = "Външни запитвания:")]
        public string Subject { get; set; }
        [NotMapped]
        public List<SelectListItem> Subjects{ get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Избери" },
            new SelectListItem { Value = "ORD", Text = "Поръчки" },
            new SelectListItem { Value = "DEL", Text = "Доставки" },
            new SelectListItem { Value = "COM", Text = "Общи въпроси" },
            new SelectListItem { Value = "OTH", Text = "Други" },
        };
        [Required(ErrorMessage = "Моля, въведете коментар!"), Display(Name = "Коментари:")]
        public string Comment { get; set; }
    }
}
