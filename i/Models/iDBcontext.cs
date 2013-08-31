using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace i.Models
{
    public class iDBcontext : DbContext
    {
        public DbSet<whatsnew> whatsnews { get; set; }
    }
    public class VersionTable
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int ID { get; set; }

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int Version { get; set; }

        [DataType(DataType.Date)]
        public virtual DateTime EntryDate { get; set; }

        public virtual string Remarks { get; set; }
    }
    public static class Updater
    {
        public static void AddorUpdate(iDBcontext context)
        {
            context.whatsnews.AddOrUpdate(
                p => p.WorkTime,

                //new whatsnew { WorkTime = new DateTime(2013, 5, 02, 10, 30, 0), Work = "add master customer" },
                //new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 30, 0), Work = "add master product" },
                //new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 20, 0), Work = "add master vendor" },

                //new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 10, 0), Work = "add bottom horizontal bar – expanding dynamically" },
                new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 10, 0), Work = "add bottom horizontal bar – expanding dynamically" },
                new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 10, 0), Work = "add accordion" },
                new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 10, 0), Work = "put colors" },
                new whatsnew { WorkTime = new DateTime(2013, 4, 26, 10, 10, 0), Work = "add logo" }
                );
        }
    }
}