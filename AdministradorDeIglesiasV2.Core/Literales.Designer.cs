﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministradorDeIglesiasV2.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Literales {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Literales() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AdministradorDeIglesiasV2.Core.Literales", typeof(Literales).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ningun maestro de un grupo de FOLI puede ser al mismo tiempo un alumno..
        /// </summary>
        internal static string AlumnoInvalido {
            get {
                return ResourceManager.GetString("AlumnoInvalido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Es necesario que la asistencia sea registrada el dia que la célula se debió de haber llevado a cabo: {0}.
        /// </summary>
        internal static string AsistenciaEnDiaIncorrecto {
            get {
                return ResourceManager.GetString("AsistenciaEnDiaIncorrecto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No es posible registrar una asistencia (o cancelación) con una fecha anterior a la fecha de la última asistencia (o cancelacion). Fecha de última asistencia (o cancelación): {0}.
        /// </summary>
        internal static string AsistenciasAntesDeUltimaAsistenciaNoValidas {
            get {
                return ResourceManager.GetString("AsistenciasAntesDeUltimaAsistenciaNoValidas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No es posible registrar una asistencia (o cancelación) con tan poco tiempo de diferencia a la anterior. Fecha mínima permitida: {0}.
        /// </summary>
        internal static string AsistenciasContiguasNoPermitidas {
            get {
                return ResourceManager.GetString("AsistenciasContiguasNoPermitidas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No es posible registrar una asistencia (o cancelación) si no se han registrado asistencias (o cancelaciones) a semanas anteriores. Posible fecha faltante: {0}.
        /// </summary>
        internal static string AsistenciasPasadasFaltantes {
            get {
                return ResourceManager.GetString("AsistenciasPasadasFaltantes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to La fecha del ensayo no puede ser posterior a la fecha del evento en sí..
        /// </summary>
        internal static string FechaDelEnsayoPosteriorAlEvento {
            get {
                return ResourceManager.GetString("FechaDelEnsayoPosteriorAlEvento", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Las fechas no se encuentran en orden cronológicamente correcto..
        /// </summary>
        internal static string FechasConOrdenCronologicoIncorrecto {
            get {
                return ResourceManager.GetString("FechasConOrdenCronologicoIncorrecto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Las fechas definidas para el grupo de Foli son inválidas (fechas de inicio de módulos y/o fecha de fin)..
        /// </summary>
        internal static string FechasDeGrupoNoValidas {
            get {
                return ResourceManager.GetString("FechasDeGrupoNoValidas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Las horas no se encuentran en orden cronológicamente correcto..
        /// </summary>
        internal static string HorasConOrdenCronologicoIncorrecto {
            get {
                return ResourceManager.GetString("HorasConOrdenCronologicoIncorrecto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No pueden existir varios líderes en una misma célula que no asistan a la misma célula. Existen 2 posibles razones, primera es que se quiera cambiar la célula a la que un usuario asiste sin haberle desasignado las células a la que es lider ó se quiere asignar como lider de una célula cuyos líderes actuales asisten a otra célula..
        /// </summary>
        internal static string LideresEnDistintasCelulas {
            get {
                return ResourceManager.GetString("LideresEnDistintasCelulas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ningun miembro puede ser líder de la célula a la que asiste. Existen 2 posibles opciones, primero cambiarlo de célula para luego poderlo marcar como líder de tal ó desmarcarlo de ser lider y cambiarlo de célula..
        /// </summary>
        internal static string MiembroNoPuedeSerLiderDeCelulaQueAsiste {
            get {
                return ResourceManager.GetString("MiembroNoPuedeSerLiderDeCelulaQueAsiste", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cada miembro deberá de tener mínimo un teléfono registrado..
        /// </summary>
        internal static string MinimoUnTelefonoRequerido {
            get {
                return ResourceManager.GetString("MinimoUnTelefonoRequerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registro padre inexistente.
        /// </summary>
        internal static string RegistroInexistente {
            get {
                return ResourceManager.GetString("RegistroInexistente", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El email y/o contraseña son inválidos..
        /// </summary>
        internal static string UsuarioYPasswordInvalidos {
            get {
                return ResourceManager.GetString("UsuarioYPasswordInvalidos", resourceCulture);
            }
        }
    }
}