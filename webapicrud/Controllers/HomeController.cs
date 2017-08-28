using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapicrud.Models;
using webapicrud.Dtos;
using AutoMapper;

namespace webapicrud.Controllers
{
    public class HomeController : ApiController
    {

        RestContext Context;
        public HomeController()
        {
            Context = new RestContext();

        }

        public IEnumerable<restDto> GetAll()
        {

            return Context.rests.ToList().Select(Mapper.Map<rest, restDto>);


        }

        public IHttpActionResult Getinfo(int id)
        {
            var get = Context.rests.SingleOrDefault(c => c.id == id);

            if (get == null)
            {
                return BadRequest();

            }
            return Ok(Mapper.Map<rest, restDto>(get));
        }



        [HttpPost]
        public IHttpActionResult CreateMe(restDto RestDto)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest();

            }

            var rinfo = Mapper.Map<restDto, rest>(RestDto);
            Context.rests.Add(rinfo);
            Context.SaveChanges();
            RestDto.id = rinfo.id;
            return Created(new Uri(Request.RequestUri + "/" + rinfo.id), RestDto);

        }


        [HttpDelete]
        public void DeleteMe(int id)
        {

            var restdel = Context.rests.SingleOrDefault(c => c.id == id);
            if (restdel == null)
            {

                throw new HttpResponseException(HttpStatusCode.NotFound);


            }


            Context.rests.Remove(restdel);
            Context.SaveChanges();

        }

        [HttpPut]

        public void UpdatCustomer(int id, restDto dto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }

            var uprest = Context.rests.SingleOrDefault(c => c.id == id);

            if (uprest == null)
            {

                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(dto, uprest);
            Context.SaveChanges();
        }
    }

}
