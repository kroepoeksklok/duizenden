import React, { Component } from "react";
import * as signalR from "@microsoft/signalr";
import { PlayerListRow } from './PlayerListRow';

export class PlayerList extends Component {
    constructor(props) {
        super(props);

        this.connection = null;
        this.state = {
            players: []
        };
    }

    componentDidMount() {
        this.connection = new signalR
            .HubConnectionBuilder()
            .withUrl("https://localhost:44327/playerHub")
            .build();

        this.connection.on("PlayerJoined", function (playerJoinedMessage) {
            console.log('playerJoinedMessage: ', playerJoinedMessage);
        });

        this.connection
            .start()
            .then(() => console.info('SignalR Connected'))
            .catch(err => console.error('SignalR Connection Error: ', err));
    }

    componentWillUnmount() {
        this.connection.stop();
    }

    render() {
        return (
            <div>
                <div>Players</div>
                <ul>
                    {this.state.players.map((player, index) => (
                        <li>
                            <PlayerListRow key={index} item={player} />
                        </li>
                    ))}
                </ul>
            </div>
        );
    }
}