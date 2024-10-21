using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GuestListManagementHub.Models;


namespace GuestListManagementHub.Controllers { 

	public class JokesController : Controller
{
    // GET: JokesController
    public async Task<IActionResult> Index()
    {
        string url = "https://official-joke-api.appspot.com/random_joke";
        using HttpClient client = new HttpClient();
        JokesModel jokes = null;

        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string result = await response.Content.ReadAsStringAsync();
            jokes = JsonConvert.DeserializeObject<JokesModel>(result);
        }

        return View(jokes);
    }

    // GET: JokesController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: JokesController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: JokesController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: JokesController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: JokesController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: JokesController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: JokesController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
}