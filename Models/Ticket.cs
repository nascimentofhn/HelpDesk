using HelpDesk.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;


namespace HelpDesk.Models
{
    public class Ticket
    {
        

        
        public Guid TicketId { get; set; }

        [Required]
        [StringLength(70)]
        [Display(Name ="Titulo do Chamado")]
        public string NameTicket { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name ="Descrição do Chamado")]
        public string Description { get; set; }

        [Display(Name ="Email")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        public string Phone { get; set; }

        [Display(Name ="Status")]

        public TicketStatus Status { get; set; }
        public TicketPriority Priority { get; set; }

       public Ticket ()
        {

        }



        public Ticket(Guid ticketId, string nameTicket, string description, string email, string phone, TicketStatus status, TicketPriority priority)
        {
            TicketId = ticketId;
            NameTicket = nameTicket;
            Description = description;
            Email = email;
            Phone = phone;
            Status = status;
            Priority = priority;
        }
        

    }
}
