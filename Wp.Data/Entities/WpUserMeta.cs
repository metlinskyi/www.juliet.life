﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    [WpTable("usermeta")]
    public partial class WpUserMeta : WpEntity<ulong>
    {
        [Key]
        [Column("umeta_id")]
        public override ulong Id { get; set; }

        [Column("user_id")]
        public ulong UserId { get; set; }

        [Column("meta_key")]
        [StringLength(255)]
        public string MetaKey { get; set; }

        [Column("meta_value")]
        public string MetaValue { get; set; }
    }
}