using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;
using ContactList.filters;
using ContactList.Models;
using DAL;
using Data.Domain;

namespace ContactList.Controllers
{
    [Authorize]
    public class ContactsController : ApiController
    {
        private readonly ContactListContext _db;

        public ContactsController()
        {

            _db = new ContactListContext();
        }
        // GET: api/Contacts
        //public ContactsVM GetContacts(string sidx, string sord, int page, int rows)
        //{
        //    var products = _db.Contacts as IEnumerable<Contact>;
        //    var pageIndex = Convert.ToInt32(page) - 1;
        //    var pageSize = rows;
        //    var totalRecords = products.Count();
        //    var totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);
        //    products = products.Skip(pageIndex * pageSize).Take(pageSize);
        //    var vm = new ContactsVM
        //    {
        //        Contact = products,
        //        page = page,
        //        records = totalRecords,
        //        total_pages = totalPages
        //    };
        //    return vm;
        //}


        //search
        public ContactsVM GetContacts([ModelBinder(typeof(JqgridBinder))]JQGridRequest request)
        {
            var products = _db.Contacts as IEnumerable<Contact>;
            var pageIndex = Convert.ToInt32(request.page) - 1;
            var pageSize = request.rows;
            var totalRecords = products.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);
            products = products.Skip(pageIndex * pageSize).Take(pageSize);
            var vm = new ContactsVM
            {
                Contact = products,
                page = request.page,
                records = totalRecords,
                total_pages = totalPages
            };
            return vm;
        }
        // GET: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public async Task<IHttpActionResult> GetContact(int id)
        {
            Contact contact = await _db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // PUT: api/Contacts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutContact(int id, Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            contact.ContactId = id;
            _db.Entry(contact).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Contacts
        [ResponseType(typeof(Contact))]
        public async Task<HttpResponseMessage> PostContact(Contact contact)
        {
            HttpResponseMessage response;
            string uri;
            if (!ModelState.IsValid)
            {
                var errorList = ModelState.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );
                response = Request.CreateResponse<Contact>(HttpStatusCode.BadRequest, contact);
                return response;
            }

            _db.Contacts.Add(contact);
            await _db.SaveChangesAsync();
            response = Request.CreateResponse<Contact>(HttpStatusCode.Created, contact);
            return response;
           // return CreatedAtRoute("DefaultApi", new { id = contact.ContactId }, contact);
        }

        // DELETE: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public async Task<IHttpActionResult> DeleteContact(int id)
        {
            Contact contact = await _db.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _db.Contacts.Remove(contact);
            await _db.SaveChangesAsync();

            return Ok(contact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactExists(int id)
        {
            return _db.Contacts.Count(e => e.ContactId == id) > 0;
        }
    }
}