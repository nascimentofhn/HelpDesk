
using System.ComponentModel.DataAnnotations;


namespace HelpDesk.Models.Enums
{
    public enum TicketStatus
    {
        Unassigned = 0,
        Open = 1,
        [Display(Name ="Em espera")]
        OnHold = 2,
        Escalated = 3,
        Closed = 4,
    }
}
