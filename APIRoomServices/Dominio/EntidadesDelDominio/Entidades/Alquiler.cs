﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.EntidadesDelDominio.Entidades
{
    public class Alquiler
    {
        public DateTime FechaAlquiler { get; set; }
        public int NumeroContrato { get; set; }
        public  byte numeroMeses;
        public Alojamiento alojamiento;
        double pagoMensual;


        public Alquiler(DateTime fechaAlquiler, int numeroContrato, byte numeroMeses, double pagoMensual)
        {
            this.FechaAlquiler = fechaAlquiler;
            this.NumeroContrato = numeroContrato;
            this.NumeroMeses = numeroMeses;
            this.PagoMensual = pagoMensual;

        }

        public Alquiler()
        {
        }

        public byte NumeroMeses
        {
            get => this.numeroMeses;
            set => this.numeroMeses = this.SetNumeroMeses(value);
        }

        public double PagoMensual
        {
            get => this.pagoMensual;
            set => this.pagoMensual = this.SetPagoMensual(value);
        }

        /// <summary>
        /// Permite establecer un valor para el pago mensual del alojamiento siempre y cuando este sea cero
        /// El valor a establecer debe ser mayor a cero, de lo contrario se lanza una excepción especificando el error
        /// </summary>
        /// <param name="pago">double con el valor del dinero a establecer para el alojamiento</param>
        /// <returns>double con el valor a establecer del alojamiento</returns>
        private double SetPagoMensual(double pago) => pago >= 0 ? pago : 0;


        /// <summary>
        /// Permite establecer la cantidad de meses en los cuales se toma un alojamiento en alquiler siempre y cuando este sea 
        /// mayor a 0
        /// de lo contrario, debe lanzarse una excepción que indica un valor erroneo en los meses a establecer.
        /// </summary>
        /// <param name="numeroMeses">byte con la cantidad de meses a esteblecer</param>
        /// <returns>Byte con la cantidad de meses a establecer</returns>
        private byte SetNumeroMeses(byte numeroMeses) => numeroMeses > 0 ? numeroMeses : (byte)0;

    }
}
