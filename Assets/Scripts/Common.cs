﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constantes
{
    public static int[,] StarDistribution = new int[5, 2]
    {   {1,40 },
        {41,50},
        {51,65},
        {66,79 },
        {80, 100}
    };


    public static List<string> Starnames = new List<string>
    {
        "﻿Achlys","Aeacus","Aegir","Aether","Age","Aion","Alfheim","Ammit","Amphion","Amun","Amunet","Ananke","Anhur","Anput","Anu","Anubis","Anuket","Aphrodite","Apis","Apollo","Apophis","Apsu","Ares","Argo","Artemis","Arthur","Asgard","Ashur","Asteria","Astraeus","Aten","Athena","Atlas","Aura","Ayaba","Babi","Bast","Bau","Bedivere","Bes","Bifrost","Borr","Bors","Bragi","Britomartis","Buldur","Buri","Camelot","Cerberus","Chaos","Chiuta","Chronos","Clymene","Coeus","Crius","Cyclops","Da","Dagon","Dagr","Dellingr","Demeter","Dimi","Dione","Dionysus","Ea","Echo","Eden","Eir","Ellel","Elli","Enki","Enten","Eos","Eostre","Epaphus","Epimetheus","Erebus","Ereshkigal","Eros","Eryx","Esus","Eurybia","Eurynome","Excalibur","Fenrir","Folkvang","Forseti","Freyja","Freyr","Frigg","Fulla","Gaheris","Gaia","Galahad","Gareth","Garm","Gawain","Gbadu","Geb","Gefjun","Geraint","Gibil","Gilgamesh","Gleti","Gu","Hades","Haenir","Hapi","Harpy","Hathor","Hati","Heket","Heimdall","Hel","Helios","Hemera","Hephaestus","Hera","Hercules","Hermes","Hermoor","Hestia","Hippolyta","Hoor","Horus","Huracan","Hyperion","Hypnos","Iapetus","Iounn","Inara","Ishara","Ishtar","Isimud","Isis","Istanu","Jerico","Jormungand","Joro","Jotunheim","Kay","Kebechet","Khepri","Khnum","Khonsu","Kuk","Kukulkan","Kvasir","Lamorak","Lancelot","Lelantos","Leto","Lif","Lifthrasir","Loa","Lofn","Loki","Loko","Maahes","Ma'at","Macaria","Madusa","Mafdet","Magni","Mami","Manni","Marduk","Mawu","Memnon","Menhit","Menoetius","Merlin","Metis","Midgard","Mimir","Minos","Mnemosyne","Myrtilus","Nabu,","Nakula","Nanna","Nanshe","Nekhbet","Neleus","Nemesis","Nephthys","Nergal","Nerthus","Nesoi","Nidavellir","Nidhogg","Nifelheim","Ninlil","Ninurta","Norn","Nott","Nut","Nynph","Nyx","Oceanus","Odin","Ophion","Orisha","Orpheus","Oshun","Osiris","Ourea","Pakhet","Pallas","Pandora","Pazuzu","Pegasus","Pelias","Percival","Perseus","Phanes","Pheobe","Pontus","Poseidon","Prometheus","Ptah","Qebui","Qetesh","Ra","Raet-Tawy","Ran","Rhadamanthus","Rhea","Rhesus","Roog","Saga","Salosteles","Satyaki","Sekhmet","Seker","Selene","Serpent","Serqet","Seshat","Seth","Shamash","Shu","Sif","Sin","Skadi","Skoll","Snotra","Sobek","Sopdu","Sphinx","Styx","Surt","Svartalfheim","Tammuz","Taranis","Tartarus","Tawaret","Tefnut","Tethys","Thalassa","Thanatos","Theia","Themis","Theseus","Thor","Thoth","Thrud","Tiamat","Tilla","Tityas","Tristan","Troy","Turnus","Tyr","Ukur","Ull","Utu","Uttu","Valhalla","Vali","Vanaheim","Var","Ve","Vidar","Vor","Wadjet","Wadj-Wer","Wer","Winti","Xevioso","Yemoja","Yggdrasil","Ymir","Zababa","Zaqar","Zethus","Zeus","Zinsi","Zinsu","Zu"
    };

}
public enum PlanetTypeEnum
{
    LushPlanet = 0,
    BarrenPlant = 1,
    GasGiant = 2
}