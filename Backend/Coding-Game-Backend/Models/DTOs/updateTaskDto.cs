﻿using System.ComponentModel.DataAnnotations;

namespace Coding_Game_Backend.Models.DTOs
{
    public class updateTaskDto
    {
        [Required]
        public int TicketID {  get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
