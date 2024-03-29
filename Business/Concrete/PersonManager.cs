﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{    
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person) 
        {
        
        }
        public List<Person> Getlist() 
        {
            return null;
        }
        public bool CheckPerson(Person person) 
        {
            //Mernis kontrol
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName,person.LastName,person.DateOfBirhYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
