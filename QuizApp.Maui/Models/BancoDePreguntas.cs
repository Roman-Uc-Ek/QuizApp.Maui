namespace QuizApp.Maui.Models
{
    public class BancoDePreguntas : IColaCircular
    {
        private IList<Pregunta> _preguntas;
        private int _indiceDePreguntaActual;
        public BancoDePreguntas()
        {
            _preguntas = new List<Pregunta>();
            _preguntas = CargarPreguntas();
            _indiceDePreguntaActual = 0;
        }
        private List<Pregunta> CargarPreguntas()
        {
            var preguntas = new List<Pregunta>();

            preguntas.Add(
            new Pregunta
            {
                Texto = "¿La peninsula de Yucatan se encuentra al norte de Mexico?",
                RespuestaEsCierto = false
            });
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿Nuestro sistema solar se enecuetra en la via lactea?",
                    RespuestaEsCierto = true
                });

            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿El oceano mas grande de nuestro planeta es el Oceano Pacifico?",
                    RespuestaEsCierto = true
                });

            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿El estado mas grande de la republica Mexicana es Sonora?",
                    RespuestaEsCierto = false
                });
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿Los vientos alisios soplan del noroeste al suroeste?",
                    RespuestaEsCierto = true
                });
            return preguntas;
        }
   
        public Pregunta ObtenerElementoAnterior()
        {
            if (_indiceDePreguntaActual > 0) 
            {
                _indiceDePreguntaActual--;
            }
            else
            {
                _indiceDePreguntaActual = _preguntas.Count - 1;
            }
            return _preguntas[_indiceDePreguntaActual];
        }

        public Pregunta ObtenerElementoSiguiente()
        {
            if (_indiceDePreguntaActual < _preguntas.Count - 1)
            {
                _indiceDePreguntaActual++;
            }
            else
            {
                _indiceDePreguntaActual = 0;
            }
            return _preguntas[_indiceDePreguntaActual];
        }

        public Pregunta ObtenerPrimerElemento()
        {
            _indiceDePreguntaActual = 0;
            return _preguntas[_indiceDePreguntaActual];
        }
    }
}
