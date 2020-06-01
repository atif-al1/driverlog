using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Drivers.Models
{
    [Table("trip")]
    public class Trip
    {
        [Key]
        public int Id{get;set;}

        [Required (ErrorMessage="Please enter driver name")]
        [Display(Name = "Enter Driver Name:")]
       public string driver {get;set;}

       [Required (ErrorMessage="Please enter valid start time")]
       [Display(Name="Start time: ")]
       public DateTime start{get;set;}

       [Required (ErrorMessage="Please enter valid end time")]
       [TimeCheck (ErrorMessage="End time must be greater than start time.")]
       [Display(Name="End Time: ")]
       public DateTime end{get;set;}

       [Required (ErrorMessage ="Please enter valid distance")]
       [Display(Name="Miles traveled: ")]
       public double miles{get;set;}
       public  double totalTimeDriven{get;set;}

       public double avgSpeed{get;set;}
       public DateTime created_at{get;set;} = DateTime.Now;
       public DateTime updated_at{get;set;} = DateTime.Now;

       public string print(){
           var printStatement = "";
           if( avgSpeed > 5 && avgSpeed< 100){
               printStatement = driver+" : "+Math.Round(miles)+"miles @ "+Math.Round(avgSpeed)+" mph";
           }
           else{
               miles = 0;
               printStatement = driver+": 0 mph";
           }
            return printStatement;   
       }
    }
}