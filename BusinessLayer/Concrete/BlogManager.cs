﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void BlogDelete(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public void BlogUpdate(Blog blog)
		{
			_blogDal.Update(blog);
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetAll(x => x.BlogID == id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetAll();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetAll(x=>x.WriterID == id);
		}
	}
}
