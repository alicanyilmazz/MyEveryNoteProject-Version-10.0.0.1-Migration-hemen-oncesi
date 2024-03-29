﻿using MyEveryNoteProject.Entities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEveryNoteProject.BusinessLayer.Results
{
    public class BusinessLayerResult<T> where T : class
    {
        public List<ErrorMessageObject> Errors { get; set; } //Bir List normalde sadece bir tip alabilirken KeyValuePair ile iki tane tip alabilir hale getirilebilir liste.
        public T Result { get; set; }

        public BusinessLayerResult()
        {
            Errors = new List<ErrorMessageObject>();
        }

        public void AddErrorMessage(ErrorMessageCode code, string message)
        {
            Errors.Add(new ErrorMessageObject() { Code = code, Message = message });
        }
    }
}
