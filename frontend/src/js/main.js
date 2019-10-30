import Header from "./component/header";
import Footer from "./component/footer";
import ArtistList from "./component/artistList";
import ArtistProfile from "./component/artistProfile";

export default () =>
{
    Pagebuild();
};

function Artistbuild(){
    ArtistProfile();
}
function Pagebuild(){
    header();
    artistList();
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