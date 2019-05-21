using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamDesign.Model;

namespace XamDesign.ViewModel
{
    class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            for (var i=0; i<10; i++)
            {
                CardDataCollection = new ObservableCollection<CardDataModel>
                {
                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },

                    new CardDataModel
                    {
                        SlapperPic = "LogoInverted.png",
                        SlapperName = "Butcher",
                        SlapperLvl = 10,
                        SlapperSPS = 1000
                    },
                };
            }

        }


    }
}
