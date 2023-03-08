using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersSecond
{
    public class ResultFilterAtt : Attribute, IResultFilter
    {
        
        private readonly ILogger<ResultFilterAtt> _logger;
        private readonly string _name;
        private readonly Guid _randomId;
        public ResultFilterAtt(ILogger<ResultFilterAtt> logger,string name="Global")
        {
            this._logger = logger;
            this._name = name;
           _randomId = Guid.NewGuid();
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
            _logger.LogInformation($"Result Filter - After - {_randomId} Name : {_name}");

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            _logger.LogInformation($"Result Filter - Before {_randomId} Name : {_name}");
        }
    }
}