using System;
namespace Transport.App.Dominio
{
    public class Revision
    {
         public int Id { get; set; }
         public int FkVehiculo { get; set; }
         public int FkMecanico { get; set; }
         public string NivelAceite  { get; set; }
         public string NivelFrenos  { get; set; }
         public string NivelRefrigerante  { get; set; }
         public string NivelDireccion  { get; set; }
         public string Observacion  { get; set; }
         

    }
}