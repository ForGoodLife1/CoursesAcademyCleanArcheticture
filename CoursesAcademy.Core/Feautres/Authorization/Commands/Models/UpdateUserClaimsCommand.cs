﻿using CoursesAcademy.Core.Bases;
using CoursesAcademy.Data.Requests;
using MediatR;

namespace CoursesAcademy.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserClaimsCommand : UpdateUserClaimsRequest, IRequest<Response<string>>
    {
    }
}
