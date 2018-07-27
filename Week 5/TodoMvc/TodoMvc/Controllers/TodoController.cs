using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoMvc.Models;

namespace TodoMvc.Controllers
{
    public class TodoController : AServiceController
    {
        public TodoController(HttpClient httpClient) : base(httpClient)
        { }

        // GET: Todo
        // we can DI into action methods too
        //public ActionResult Index([FromServices] HttpClient client)
        public async Task<ActionResult> Index()
        {
            
            var request = CreateRequestToService(HttpMethod.Get, "api/Todo");

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("Error");
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                List<TodoItem> todo = JsonConvert.DeserializeObject<List<TodoItem>>(jsonString);

                return View(todo);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TodoItem item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }

            try
            {
                string jsonString = JsonConvert.SerializeObject(item);

                var request = CreateRequestToService(HttpMethod.Post, "api/Todo");
                // we set what the Content-Type header will be here
                request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("Error");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}