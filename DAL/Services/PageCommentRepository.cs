﻿using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PageCommentRepository : IPageComment
    {
        DBContextsModels DB;
        public PageCommentRepository(DBContextsModels db)
        {
            this.DB = db;
        }

        public bool AddComment(PageComment pageComment)
        {
            try
            {
                DB.PageComments.Add(pageComment);
                DB.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void Dispose()
        {
            DB.Dispose();
        }

        public IEnumerable<PageComment> GetCommentByNewsId(int pageId)
        {
            return DB.PageComments.Where(c => c.PageId == pageId);
        }

    }
}
