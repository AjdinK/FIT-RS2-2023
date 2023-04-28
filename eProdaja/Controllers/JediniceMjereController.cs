﻿using eProdaja.DataBase;
using eProdaja.Model.SearchObjects;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers {

    public class JediniceMjereController : BaseController<Model.JediniceMjere, JediniceMjereSearchObject> {

        public JediniceMjereController(IService<Model.JediniceMjere , JediniceMjereSearchObject> service) : base(service) {
           
        }
    }
}
