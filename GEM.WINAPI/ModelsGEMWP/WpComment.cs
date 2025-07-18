﻿using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpComment
{
    public long CommentId { get; set; }

    public long CommentPostId { get; set; }

    public string CommentAuthor { get; set; } = null!;

    public string CommentAuthorEmail { get; set; } = null!;

    public string CommentAuthorUrl { get; set; } = null!;

    public string CommentAuthorIp { get; set; } = null!;

    public DateTime CommentDate { get; set; }

    public DateTime CommentDateGmt { get; set; }

    public string CommentContent { get; set; } = null!;

    public int CommentKarma { get; set; }

    public string CommentApproved { get; set; } = null!;

    public string CommentAgent { get; set; } = null!;

    public string CommentType { get; set; } = null!;

    public long CommentParent { get; set; }

    public long UserId { get; set; }
}
