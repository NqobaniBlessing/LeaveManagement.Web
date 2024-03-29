﻿using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers
{
    [Authorize]
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository _leaveTypeRepo;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepo, IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveTypeRepo = leaveTypeRepo;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = _mapper.Map<List<LeaveTypeVM>>(await _leaveTypeRepo.GetAllAsync());
            return View(leaveTypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await _leaveTypeRepo.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        [Authorize(Roles = Roles.Administrator)]
        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                await _leaveTypeRepo.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        [Authorize(Roles = Roles.Administrator)]
        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await _leaveTypeRepo.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypeRepo.GetAsync(id);

            if (leaveType == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    leaveType = await _leaveTypeRepo.GetAsync(id);
                    _mapper.Map(leaveTypeVM, leaveType);

                    await _leaveTypeRepo.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _leaveTypeRepo.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        [Authorize(Roles = Roles.Administrator)]
        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _leaveTypeRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AllocateLeave(int id)
        {
            await _leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
