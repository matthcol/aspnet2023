using Microsoft.AspNetCore.Mvc;
using Peages.Models;

namespace Peages.Controllers
{

    // [Route("/clients/[action=Index]")]
    [Route("/clients")]
    public class ClientController : Controller
    {

        private static IList<Client> _clients = new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "Matthias",
                    Birthdate = DateTime.Today
                },
                new Client
                {
                    Id = 2,
                    Name = "Patrice",
                    Birthdate = new DateTime(1900,2,28)
                },
                 new Client
                {
                    Id = 3,
                    Name = "Elodie"               
                }
            };


        public IActionResult Index()
        {
            
            return View(_clients);
        }

        [Route("{id}")]
        public IActionResult ClientById(int id)
        {
            /*var client = new Client
            {
                Id = id,
                Name = "Matthias",
                Birthdate = DateTime.Today
            };*/
            Client? client = _clients.FirstOrDefault(c => c?.Id == id, null);
            if (client == null)
                return NotFound();
            return View("ClientDetail", client);
        }

        [Route("create")]
        public IActionResult Create()
        {
            // send view with form
            return View("CreateOrUpdate");
        }

        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var client = _clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                return NotFound();
            // send view with form
            return View("CreateOrUpdate", client);
        }

        [Route("save")]
        [HttpPost]
        // public IActionResult Create([FromBody] Client client) // api REST
        public IActionResult Create([Bind("Id,Name,Birthdate")] Client client) // MVC from Form
        // public IActionResult Create([ModelBinder(typeof(Client))] Client client) // miss croncrete binder
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);
            // receive form
            if (client.Id == 0)
            {
                client.Id = _clients.Max(c => c.Id) + 1;
                _clients.Add(client);
            } else
            {
                var index = _clients.Select((item, i) => new {
                    Item = item,
                    Position = i
                }).Where(m => m.Item.Id == client.Id).First().Position;
                _clients[index] = client;
            }
            
            return RedirectToAction(nameof(Index));
        }

    }
}
