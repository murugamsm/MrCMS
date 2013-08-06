﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MrCMS.Services;

namespace MrCMS.Entities.Messaging
{
    public abstract class MessageTemplate : SiteEntity
    {
        [Display(Name = "Message Template Type")]
        public virtual string MessageTemplateType { get { return GetType().Name; } }

        [Required]
        [Display(Name = "From Address")]
        public virtual string FromAddress { get; set; }
        [Required]
        [Display(Name = "From Name")]
        public virtual string FromName { get; set; }

        [Required]
        [Display(Name = "To Address")]
        public virtual string ToAddress { get; set; }
        [Display(Name = "To Name")]
        public virtual string ToName { get; set; }

        public virtual string Cc { get; set; }
        public virtual string Bcc { get; set; }

        [Required]
        public virtual string Subject { get; set; }
        [Required]
        public virtual string Body { get; set; }

        [Required]
        [Display(Name = "Is HTML?")]
        public virtual bool IsHtml { get; set; }

        public abstract MessageTemplate GetInitialTemplate();

        public abstract List<string> GetTokens(IMessageTemplateParser messageTemplateParser);
    }
}
