﻿namespace MeuCondominio.Models.ViewModels
{
    public class OccurrenceFormViewModel
    {
        public Occurrence Occurrence { get; set; }
        public ICollection<Resident> Residents { get; set; }
    }
}
