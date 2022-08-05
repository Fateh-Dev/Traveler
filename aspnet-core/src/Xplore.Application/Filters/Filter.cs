using System;
using Volo.Abp.Application.Dtos;

public class ScheduleFilter : PagedAndSortedResultRequestDto
{
    public Guid IdTrip { get; set; }
}
