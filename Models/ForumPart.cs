﻿using System;
using Orchard.ContentManagement;
using Orchard.Core.Routable.Models;

namespace NGM.Forum.Models {
    public class ForumPart : ContentPart<ForumPartRecord> {
        public string Title {
            get { return this.As<RoutePart>().Title; }
            set { this.As<RoutePart>().Title = value; }
        }

        public int ThreadCount {
            get { return Record.ThreadCount; }
            set { Record.ThreadCount = value; }
        }

        public int PostCount {
            get { return Record.PostCount; }
            set { Record.PostCount = value; }
        }

        public bool IsClosed {
            get { return Record.IsClosed; }
            set { Record.IsClosed = value; }
        }

        public bool UsePopularityAlgorithm {
            get { return Record.UsePopularityAlgorithm; }
            set { Record.UsePopularityAlgorithm = value; }
        }

        public int Position {
            get { return Record.Position; }
            set { Record.Position = value; }
        }

        public int ReplyCount {
            get { return PostCount >= 1 ? PostCount - ThreadCount : 0; }
        }

        /* Category.. Not sure if I should move Category out of Forum and attach it via a part. */
        public string CategoryTitle {
            get { return ""; }
            set { }
        }

        public int CategoryPosition {
            get { return 1; }
            set { }
        }
    }
}