﻿using AutoMapper;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Services.Communications;
using GrupoWebBackend.DomainAdvertisements.Domain.Models;
using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.DomainAdoptionsRequests.Resources;
using GrupoWebBackend.DomainAdvertisements.Resources;
using GrupoWebBackend.DomainPublications.Resources;
using GrupoWebBackend.Security.Domain.Entities;
using GrupoWebBackend.Security.Domain.Services.Communication;
using GrupoWebBackend.Security.Resources;

namespace GrupoWebBackend.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Advertisement, AdvertisementResource>();
            CreateMap<Publication, PublicationResource>();
            CreateMap<AdoptionsRequests, AdoptionsRequestsResource>();
            CreateMap<User, RegisterRequest>();
            CreateMap<User, AuthenticateResponse>();
            CreateMap<User, AuthenticateRequest>();
            CreateMap<User, UserResource>();
            
            
            
        }
    }
}
