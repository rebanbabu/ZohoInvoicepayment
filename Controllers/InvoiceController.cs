using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Zoho.Models;

namespace Zoho.Controllers;

public class InvoicesController : Controller
{
    private readonly InvoiceRepository _invoiceRepository;

    public InvoicesController(InvoiceRepository invoiceRepository)
    {
        _invoiceRepository = invoiceRepository;
    }

    // GET: /Invoices
    public ActionResult Index()
    {
        List<Invoice> invoices = _invoiceRepository.GetAll();
        return View(invoices);
    }

    // GET: /Invoices/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: /Invoices/Create
    [HttpPost]
    public ActionResult Create(Invoice invoice)
    {
        if (ModelState.IsValid)
        {
            _invoiceRepository.Create(invoice);
            return RedirectToAction("Index");
        }
        return View(invoice);
    }

    // GET: /Invoices/Edit/5
    public ActionResult Edit(int id)
    {
        Invoice invoice = _invoiceRepository.GetById(id);
        if (invoice == null)
        {
            return HttpNotFound();
        }
        return View(invoice);
    }

    // POST: /Invoices/Edit/5
    [HttpPost]
    public ActionResult Edit(Invoice invoice)
    {
        if (ModelState.IsValid)
        {
            _invoiceRepository.Update(invoice);
            return RedirectToAction("Index");
        }
        return View(invoice);
    }

    // GET: /Invoices/Delete/5
    public ActionResult Delete(int id)
    {
        Invoice invoice = _invoiceRepository.GetById(id);
        if (invoice == null)
        {
            return HttpNotFound();
        }
        return View(invoice);
    }

    // POST: /Invoices/Delete/5
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        Invoice invoice = _invoiceRepository.GetById(id);
        _invoiceRepository.Delete(invoice);
        return RedirectToAction("Index");
    }
}

