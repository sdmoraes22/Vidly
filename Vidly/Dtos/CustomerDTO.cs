using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDTO
    {
        public int Customerid { get; set; }

        [Required(ErrorMessage = "Por favor faça a inserção do nome de usuário.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte Comum = 0;
    }
}