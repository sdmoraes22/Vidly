using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Customerid { get; set; }

        [Required(ErrorMessage = "Por favor faça a inserção do nome de usuário.")]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte Comum = 0;
    }
}