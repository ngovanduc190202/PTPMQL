using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{

public class student
{
    [Key]

    public string fullname {get;set;}
    public string address {get;set;}
}
}

