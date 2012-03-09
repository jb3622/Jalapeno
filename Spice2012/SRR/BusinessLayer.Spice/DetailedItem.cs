using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Disney.iDash.BusinessLayer
{
    public class DetailedItem : ItemBase
    {
        public string Item { get; set; }
        public decimal Class { get; set; }
        public decimal Vendor { get; set; }
        public decimal Style { get; set; }
        public decimal Colour { get; set; }
        public decimal Size { get; set; }
        public string Description { get; set; }
        public string Market { get; set; }
        public string Grade { get; set; }
        public string Gradedescription { get; set; }
        public decimal Store { get; set; }
        public string Storename { get; set; }
        public string Storetype { get; set; }
        public string Workbench { get; set; }
        public decimal Saleslw { get; set; }
        public decimal Salestw { get; set; }
        public decimal Smoothedrateofsale { get; set; }
        public decimal Newsmoothedrateofsale { get; set; }
        public decimal Storesoh { get; set; }
        public decimal Smoothedstorecover { get; set; }
        public decimal Totalstockrequired { get; set; }
        public decimal Ringfenced { get; set; }
        public decimal Allocated { get; set; }
        public string Giveitback { get; set; }
        public decimal Shipped { get; set; }
        public decimal Mindispqty { get; set; }
        public decimal Idealallocqty { get; set; }
        public decimal Proposedallocqty { get; set; }
        public string Allocationlevel { get; set; }
        public decimal Edcstock { get; set; }
        public decimal Smoothededccover { get; set; }
        public string Nextdeliverydate { get; set; }
        public decimal Nextorderqty { get; set; }
        public decimal Curpattern { get; set; }
        public decimal Patternhierarchylevel { get; set; }
        public decimal Newpattern { get; set; }
        public string Patternthislevel { get; set; }
        public string Patternstatus { get; set; }
        public decimal Curupliftfactor { get; set; }
        public decimal Uplifthierarchylevel { get; set; }
        public decimal Newupliftfactor { get; set; }
        public string Upliftthislevel { get; set; }
        public string Upliftstatus { get; set; }
        public decimal Curcutoff { get; set; }
        public decimal Cutoffhierarchylevel { get; set; }
        public decimal Newcutoff { get; set; }
        public string Cutoffthislevel { get; set; }
        public string Cutoffstatus { get; set; }
        public string Curallocflag { get; set; }
        public decimal Allocflaghierarchylevel { get; set; }
        public string Newallocflag { get; set; }
        public string Allocflagthislevel { get; set; }
        public string Allocflagstatus { get; set; }
        public decimal Cursmoothingfactor { get; set; }
        public decimal Smoothingfactorhierarchylevel { get; set; }
        public decimal Newsmoothingfactor { get; set; }
        public string Smoothingfactorthislevel { get; set; }
        public string Smoothingfactorstatus { get; set; }
        public decimal Daysoutofstock { get; set; }
        public string Upc { get; set; }
        public decimal Lastpickqty { get; set; }
        public string Pack { get; set; }
        public string Packitem { get; set; }
    }

  }
