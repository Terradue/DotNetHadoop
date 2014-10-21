﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace Terradue.Hadoop.WebHDFS
{
    // todo - make abstract
    public class DirectoryListing : Resource
    {
        IEnumerable<DirectoryEntry> directoryEntries;

        public DirectoryListing(JsonObject rootEntry)
        {
            directoryEntries = rootEntry.Object("FileStatuses").ArrayObjects("FileStatus").Select(fs => new DirectoryEntry(fs));
            Info = rootEntry;
        }

        public IEnumerable<DirectoryEntry> Entries { get { return directoryEntries; } }
        public IEnumerable<DirectoryEntry> Directories { get { return directoryEntries.Where(fs => fs.Type == "DIRECTORY"); } }
        public IEnumerable<DirectoryEntry> Files { get { return directoryEntries.Where(fs => fs.Type == "FILE"); } }
    }
}
