﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    [WpTable("termmeta")]
    public partial class WpTermMeta : WpEntity<ulong>
    {
        [Key]
        [Column("meta_id")]
        public override ulong Id { get; set; }

        [Column("term_id")]
        public ulong TermId { get; set; }

        [Column("meta_key")]
        [StringLength(255)]
        public string MetaKey { get; set; }

        [Column("meta_value")]
        public string MetaValue { get; set; }
    }
}