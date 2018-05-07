﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wp.Web.Tags
{
    [HtmlTargetElement("wp-footer")]
    public class WpTagFooter : WpTag
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.SuppressOutput();
        }
    }
}
