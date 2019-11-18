using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Academico.DAL.DataModels;

namespace Sistema_Academico.DAL
{
    public class UnitOfWork
    {
        private Data Context;

        public UnitOfWork()
        {
            Context = new Data();
        }

        private Repository<Ciclo> _cicloRepository;

        public Repository<Ciclo> CicloRepository
        {
            get
            {
                if (_cicloRepository == null)
                    _cicloRepository = new Repository<Ciclo>(Context);
                return _cicloRepository;
            }

        }
        private Repository<Grado> _gradoRepository;

        public Repository<Grado> GradoRepository
        {
            get
            {
                if (_gradoRepository == null)
                    _gradoRepository = new Repository<Grado>(Context);
                return _gradoRepository;
            }

        }
        private Repository<Materia> _materiaRepository;

        public Repository<Materia> MateriaRepository
        {
            get
            {
                if (_materiaRepository == null)
                    _materiaRepository = new Repository<Materia>(Context);
                return _materiaRepository;
            }

        }
        private Repository<Matricula> _matriculaRepository;

        public Repository<Matricula> MatriculaRepository
        {
            get
            {
                if (_matriculaRepository == null)
                    _matriculaRepository = new Repository<Matricula>(Context);
                return _matriculaRepository;
            }

        }
        private Repository<Notas> _notasRepository;

        public Repository<Notas> NotasRepository
        {
            get
            {
                if (_notasRepository == null)
                    _notasRepository = new Repository<Notas>(Context);
                return _notasRepository;
            }

        }
       
        private Repository<Years> _yearsRepository;

        public Repository<Years> YearsRepository
        {
            get
            {
                if (_yearsRepository == null)
                    _yearsRepository = new Repository<Years>(Context);
                return _yearsRepository;
            }

        }
        private Repository<Valores> _valoresRepository;

        public Repository<Valores> ValoresRepository
        {
            get
            {
                if (_valoresRepository == null)
                    _valoresRepository = new Repository<Valores>(Context);
                return _valoresRepository;
            }

        }
        private Repository<NotasValores> _notasvaloresRepository;

        public Repository<NotasValores> NotasValoresRepository
        {
            get
            {
                if (_notasvaloresRepository == null)
                    _notasvaloresRepository = new Repository<NotasValores>(Context);
                return _notasvaloresRepository;
            }

        }
        private Repository<usuario_admin> _usuario_Admin;

        public Repository<usuario_admin> Usuario_AdminRepository
        {
            get
            {
                if (Usuario_AdminRepository == null)
                    _usuario_Admin = new Repository<usuario_admin>(Context);
                return Usuario_AdminRepository;
            }


        }
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
