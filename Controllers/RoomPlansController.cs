﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArApiProvider.Data;
using ArApiProvider.Models;
using Microsoft.AspNetCore.Authorization;

namespace ArApiProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomPlansController : ControllerBase
    {
        private readonly RoomsDbContext _context;

        public RoomPlansController(RoomsDbContext context)
        {
            _context = context;
        }

        // GET: api/RoomPlans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomPlan>>> GetRoomPlans()
        {
            return await _context.RoomPlans.ToListAsync();
        }

        // GET: api/RoomPlans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomPlan>> GetRoomPlan(int id)
        {
            var roomPlan = await _context.RoomPlans.FindAsync(id);

            if (roomPlan == null)
            {
                return NotFound();
            }

            return roomPlan;
        }

        // PUT: api/RoomPlans/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomPlan(int id, RoomPlan roomPlan)
        {
            if (id != roomPlan.Id)
            {
                return BadRequest();
            }

            _context.Entry(roomPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomPlanExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RoomPlans
        [HttpPost]
        public async Task<ActionResult<RoomPlan>> PostRoomPlan(RoomPlan roomPlan)
        {
            _context.RoomPlans.Add(roomPlan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoomPlan", new { id = roomPlan.Id }, roomPlan);
        }

        // DELETE: api/RoomPlans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoomPlan>> DeleteRoomPlan(int id)
        {
            var roomPlan = await _context.RoomPlans.FindAsync(id);
            if (roomPlan == null)
            {
                return NotFound();
            }

            _context.RoomPlans.Remove(roomPlan);
            await _context.SaveChangesAsync();

            return roomPlan;
        }

        private bool RoomPlanExists(int id)
        {
            return _context.RoomPlans.Any(e => e.Id == id);
        }
    }
}
