﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shoko.Database.Models.Crossref
{
    [Table("CrossRef_AniDB_Other")]
    public class AniDbOther
    {
        [Key, Column("CrossRef_AniDB_OtherID")] public int Id { get; set; }

    }
}