import Header from "./component/header";
import Footer from "./component/footer";
import Artists from "./component/Artists";
import Artist from"./component/Artist";
import AddAlbum from "./component/AddAlbum"
import Albums from "./component/Albums";
import Album from "./component/Album";
import apiActions from "./API/apiActions";
import Songs from "./component/Songs";
import Song from "./component/Song";


export default () =>
{
    Pagebuild();
};

function Pagebuild(){
    header();
    navHome();
    navArtists();
    navAlbums();
    navSongs();
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
// function Artists(){
//     const Artists = document.getElementById("artist-list");
//     Artists.innerHTML = Artists();

// function artistProfile(){
//     const artistProfile = document.getElementById("artist-profile");
//     artistProfile.innerHTML = ArtistProfile();
// }
// function albumList(){
//     const albumList = document.getElementById("album-div");
//     ApiActions.getRequest("https://localhost:44386/api/albums", albums => {
//     albumList.innerHTML = AlbumList(albums);
//     });
// }
function navHome(){
    apiActions.getRequest("https://localhost:44386/api/artists", artists => {
     document.querySelector("#app").innerHTML = Artists(artists);
        });
    }

function navArtists(){
    const artistsButton= document.querySelector(".nav__artists");
    const app = document.querySelector("#app");
    artistsButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44386/api/artists", artists => {
            document.querySelector("#app").innerHTML = Artists(artists);
        });
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("artist__image")){
            const artistID = event.target.parentElement.querySelector(".artist__id").value;
            console.log(artistID);
            apiActions.getRequest(`https://localhost:44386/api/artists/${artistID}`,
                artist => {
                    console.log(artist.albums)

                app.innerHTML= Albums(artist.albums);
            })
        }
    });

    app.addEventListener('click', function(){
        if(event.target.classList.contains("add-artist__submit")){
            const artist = event.target.parentElement.querySelector(
                ".add-artist__artistname"
            ).value;
            const image = event.target.parentElement.querySelector(
                ".add-artist__artistimg"
            ).value;
            console.log(artist);
            apiActions.postRequest("https://localhost:44386/api/artists",
            {
                name: artist,
                image: image
            },
            artists => {
                console.log(artists);
                app.innerHTML = Artists(artists);
             });
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-artist__submit")){
            const artistID = event.target.parentElement.querySelector(".artist__id").value;
            console.log("delete" + artistID)
            apiActions.deleteRequest(`https://localhost:44386/api/artists/${artistID}`,
                artists => {
                app.innerHTML = Artists(artists);
            });
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-artist__submit")){
            const artistID = event.target.parentElement.querySelector(".artist__id").value;
            console.log("edit" + artistID);
            apiActions.getRequest(`https://localhost:44386/api/artists/${artistID}`,
                artist => {
                app.innerHTML= Artist(artist);
            })
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-artist__submit")){
            const artistID = event.target.parentElement.querySelector(
                ".update-artist__id"
            ).value;
            const artistName = event.target.parentElement.querySelector(".update-artist__name"
            ).value;
            const artistData = {
                id: artistID,
                name: artistName
            }
            apiActions.putRequest(`https://localhost:44386/api/artists/${artistID}`,
            artistData,
            artists => {
                app.innerHTML = Artists(artists)
            }
            );
        }
    });
}
    function navAlbums(){
        const albumsButton = document.querySelector(".nav__albums");
        const app = document.querySelector("#app");
        albumsButton.addEventListener("click", function(){
            apiActions.getRequest("https://localhost:44386/api/albums", albums => {
                app.innerHTML = Albums(albums);
            });
        });

        app.addEventListener("click", function(){
            if(event.target.classList.contains("album__image")){
                const albumID = event.target.parentElement.querySelector(".album__id").value;
                console.log(albumID);
                apiActions.getRequest(`https://localhost:44386/api/albums/${albumID}`,
                    album => {
                        console.log(album.songs)
    
                    app.innerHTML= Songs(album.songs);
                })
            }
        });
    
        app.addEventListener('click', function(){
            if(event.target.classList.contains("add-album__submit")){
                const album = event.target.parentElement.querySelector(
                    ".add-album__albumtitle"
                ).value;
                const image = event.target.parentElement.querySelector(
                    ".add-album__albumimg"
                ).value;
                const artistId = event.target.parentElement.querySelector(
                    ".add-album__artistId"
                ).value;
                console.log(album);
                apiActions.postRequest("https://localhost:44386/api/albums",
                {
                    title: album,
                    image: image,
                    artistId: artistId
                },
                albums => {
                    console.log(albums);
                    app.innerHTML = Albums(albums);
                 });
            }
        });
        app.addEventListener("click", function(){
            if(event.target.classList.contains("delete-album__submit")){
                const albumID = event.target.parentElement.querySelector(".album__id").value;
                console.log("delete" + albumID)
                apiActions.deleteRequest(`https://localhost:44386/api/albums/${albumID}`,
                albums => {
                    app.innerHTML = Albums(albums);
                })
            }
        });
        app.addEventListener("click", function(){
            if(event.target.classList.contains("edit-album__submit")){
                const albumID = event.target.parentElement.querySelector(".album__id").value;
                console.log("edit" + albumID);
                apiActions.getRequest(
                    `https://localhost:44386/api/albums/${albumID}`,
                    album => {
                        app.innerHTML= Album(album);
                    });
            }
        });
        app.addEventListener("click", function(){
            if(event.target.classList.contains("update-album__submit")){
                const albumID = event.target.parentElement.querySelector(
                    ".update-album__id"
                ).value;
                const albumTitle = event.target.parentElement.querySelector(".update-album__name"
                ).value;
                const artistId = event.target.parentElement.querySelector(".update-album__artistId"
                ).value;
                const albumData = {
                    id: albumID,
                    title: albumTitle,
                    artistId: artistId
                }
                apiActions.putRequest(`https://localhost:44386/api/albums/${albumID}`,
                albumData,
                albums => {
                    app.innerHTML = Albums(albums)
                }
                );
            }
        });
    }
        function navSongs(){
            const songsButton= document.querySelector(".nav__songs");
            const app = document.querySelector("#app");
            songsButton.addEventListener("click", function(){
                apiActions.getRequest("https://localhost:44386/api/songs", songs => {
                    document.querySelector("#app").innerHTML = Songs(songs);
                });
            });
            app.addEventListener('click', function(){
                if(event.target.classList.contains("add-song__submit")){
                    const song = event.target.parentElement.querySelector(
                        ".add-song__songtitle"
                    ).value;
                    const albumId = event.target.parentElement.querySelector(
                        ".add-song__albumId"
                    ).value;
                    const image = event.target.parentElement.querySelector(
                        ".add-song__songimage"
                    ).value;
                    console.log(song);
                    apiActions.postRequest("https://localhost:44386/api/songs",
                    {
                        title: song,
                        albumId: albumId,
                        image: image
                    },
                    songs => {
                        console.log(songs);
                        app.innerHTML = Songs(songs);
                     });
                }
            });
            app.addEventListener("click", function(){
                if(event.target.classList.contains("delete-song__submit")){
                    const songID = event.target.parentElement.querySelector(".song__id").value;
                    console.log("delete" + songID)
                    apiActions.deleteRequest(`https://localhost:44386/api/songs/${songID}`,
                    songs => {
                        app.innerHTML = Songs(songs);
                    })
                    
                }
            });
            app.addEventListener("click", function(){
                if(event.target.classList.contains("edit-song__submit")){
                    const songID = event.target.parentElement.querySelector(".song__id").value;
                    console.log("edit" + songID);
                    apiActions.getRequest(
                        `https://localhost:44386/api/songs/${songID}`,
                        song => {
                            app.innerHTML= Song(song);
                        });
                }
            });
            app.addEventListener("click", function(){
                if(event.target.classList.contains("update-song__submit")){
                    const songID = event.target.parentElement.querySelector(
                        ".update-song__id"
                    ).value;
                    const songTitle = event.target.parentElement.querySelector(".update-song__name"
                    ).value;
                    const albumId = event.target.parentElement.querySelector(".update-song__albumId"
                    ).value;
                    const image = event.target.parentElement.querySelector(".update-song__image"
                    ).value;
    
                    const songData = {
                        id: songID,
                        title: songTitle,
                        albumId: albumId,
                        image: image
                    }
                    apiActions.putRequest(`https://localhost:44386/api/songs/${songID}`,
                    songData,
                    songs => {
                        app.innerHTML = Songs(songs)
                    }
                    );
                }
            });
    
        }
        
   
