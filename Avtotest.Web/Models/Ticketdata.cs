﻿namespace Avtotest.Web.Models;

public class Ticketdata
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public int QuestionId { get; set; }
    public int ChoiceId { get; set; }
    public bool Answer { get; set; }

}
