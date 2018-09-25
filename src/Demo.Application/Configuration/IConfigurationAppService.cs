﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Demo.Configuration.Dto;

namespace Demo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}