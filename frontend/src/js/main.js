import Header from "./component/header";
import Footer from "./component/footer";
import ArtistList from "./component/artistList";
import ArtistProfile from "./component/artistProfile";
import AlbumList from "./component/albumList";

export default () =>
{
    Pagebuild();
};

function Artistbuild(){
    artistProfile();
    albumList();
}
function Pagebuild(){
    header();
    artistProfile();
    artistList();
    albumList();
    footer();
};

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header();
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer();
}
function artistList(){
    const artistList = document.getElementById("artist-list");
    artistList.innerHTML = ArtistList();
}
function artistProfile(){
    const artistProfile = document.getElementById("artist-profile");
    artistProfile.innerHTML = ArtistProfile();
}
function albumList(){
    const albumList = document.getElementById("album-div");
    albumList.innerHTML = AlbumList();
}