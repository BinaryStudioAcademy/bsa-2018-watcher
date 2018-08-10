using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccumulator.Entities;
using DataAccumulator.Interfaces;
using DataAccumulator.Models;

namespace DataAccumulator.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/dataaccumulator")]
    public class DataAccumulatorController : Controller
    {
        private readonly IDataAccumulatorRepository _repository;

        public DataAccumulatorController(IDataAccumulatorRepository repository)
        {
            _repository = repository;
        }

        // GET: api/v1/dataaccumulator
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var entities = await _repository.GetAllEntities();
                if (entities == null)
                {
                    return NotFound();
                }

                return Ok(entities);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // GET: api/v1/dataaccumulator/5
        [HttpGet("{id}", Name = "GetDataAccumulator")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var entity = await _repository.GetEntity(id);
                if (entity == null)
                {
                    return NotFound();
                }

                return Ok(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // POST: api/v1/dataaccumulator
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CollectedDataDto collectedDataDto)
        {
            try
            {
                // todo
                var collectedData = new CollectedData()
                {
                    Id = collectedDataDto.Id
                };

                await _repository.AddEntity(collectedData);
                return CreatedAtRoute("GetDataAccumulator", new { id = collectedDataDto.Id }, collectedData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // POST: api/v1/dataaccumulator/bytearray
        [HttpPost(Name = "bytearray")]
        public async Task<IActionResult> Post([FromBody]byte[] collectedDataByte)
        {
            try
            {
                CollectedData collectedData;

                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream(collectedDataByte))
                {
                    object obj = bf.Deserialize(ms);
                    collectedData = (CollectedData) obj;
                }

                await _repository.AddEntity(collectedData);

                return NoContent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // PUT: api/v1/dataaccumulator/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody]CollectedDataDto collectedDataDto)
        {
            try
            {
                collectedDataDto.Id = id;
                await _repository.UpdateEntity(id, collectedDataDto);
                return NoContent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // DELETE: api/v1/dataaccumulator/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _repository.RemoveEntity(id);
                return NoContent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }
    }
}
